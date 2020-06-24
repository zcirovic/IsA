import * as React from 'react';
import DataTable from 'react-data-table-component';
import FetchBanke from './FetchBanke';
import { useState } from 'react';
import FetchBanka2Service  from './FetchBanka2Service';

const data = [{ id: 1, title: 'Conan the Barbarian', year: '1982' }];
const columns = [
    {
        name: 'Title',
        selector: 'title',
        sortable: true,
    },
    {
        name: 'Year',
        selector: 'year',
        sortable: true,
        right: true,
    },
];

export type ColumnTip = {
    name: string;
    selector: string;
    sortable: boolean;
    right: boolean;
}
var x: ColumnTip;


var cols1: ColumnTip[] = [
    {
        name: 'Id',
        selector: 'id',
        sortable: true,
    } as ColumnTip,
    {
        name: 'Naziv',
        selector: 'naziv',
        sortable: true,
    } as ColumnTip,
    {
        name: 'Mesto',
        selector: 'mesto',
        sortable: true,
    } as ColumnTip,
    {
        name: 'Adresa',
        selector: 'adresa',
        sortable: true,
        right: true,
    } as ColumnTip
];

export interface BankaData {
    id: number;
    naziv: string;
    mesto: string;
    adresa: string;
}

interface ServiceInit {
    status: 'init';
}
interface ServiceLoading {
    status: 'loading';
}
interface ServiceLoaded<T> {
    status: 'loaded';
    payload: T;
}
interface ServiceError {
    status: 'error';
    error: Error;
}
export type Service<T> =
    | ServiceInit
    | ServiceLoading
    | ServiceLoaded<T>
    | ServiceError;


interface Props {
    cols: ColumnTip[]
};


//const FetchBanke2: React.FC<Props> = ({ cols } ) => {
//    return (
//        <DataTable
//            title="Arnold Movies"
//            columns={cols}
//            data={data}
//        />
//    )
//}


//export default FetchBanke2;

const FetchBanke2: React.FC<{}> = ({ }) => {
    const service = FetchBanka2Service();
    
    return (
        <div>
            {service.status === 'loading' && <div>Loading...</div>}
            {service.status === 'loaded' &&
                <div key={service.data.Id}>{service.data.naziv}</div>}
            {service.status === 'error' &&
                <div>Error, the backend moved to the dark side.</div>
            }
            {console.log(service.status)}
        </div>
    );
}


export default FetchBanke2;