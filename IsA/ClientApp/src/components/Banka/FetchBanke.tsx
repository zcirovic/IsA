import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../../store';
import * as BankaStore from '../../store/Banke';

// At runtime, Redux will merge together...
type BankaProps =
  BankaStore.BankeState // ... state we've requested from the Redux store
  & typeof BankaStore.actionCreators // ... plus action creators we've requested
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters


class FetchData extends React.PureComponent<BankaProps> {
  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
  }

  public render() {
    return (
      <React.Fragment>
        <h1 id="tabelLabel">Banke</h1>
        <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
        {this.renderBankeTable()}
        {this.renderPagination()}
      </React.Fragment>
    );
  }

  private ensureDataFetched() {
    const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
      this.props.requestBanke(startDateIndex);
  }

  private renderBankeTable() {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>id</th>
            <th>Naziv</th>
            <th>Mesto</th>
            <th>Adresa</th>
          </tr>
        </thead>
            <tbody>
                {this.props.banke.map((banke: BankaStore.Banka) =>
                    <tr key={banke.id}>
                        <td>{banke.id}</td>
                        <td>{banke.naziv}</td>
                        <td>{banke.mesto}</td>
                        <td>{banke.adresa}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  private renderPagination() {
    const prevStartDateIndex = (this.props.startDateIndex || 0) - 5;
    const nextStartDateIndex = (this.props.startDateIndex || 0) + 5;

    return (
      <div className="d-flex justify-content-between">
        <Link className='btn btn-outline-secondary btn-sm' to={`/banka/${prevStartDateIndex}`}>Previous</Link>
        {this.props.isLoading && <span>Loading...</span>}
        <Link className='btn btn-outline-secondary btn-sm' to={`/banka/${nextStartDateIndex}`}>Next</Link>
      </div>
    );
  }
}

export default connect(
    (state: ApplicationState) => state.banke, // Selects which state properties are merged into the component's props
    BankaStore.actionCreators // Selects which action creators are merged into the component's props
)(FetchData as any);
