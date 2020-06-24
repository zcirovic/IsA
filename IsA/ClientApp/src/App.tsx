import * as React from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from './components/FetchData';
import FetchBanke from './components/Banka/FetchBanke'
import FetchBanke2, { ColumnTip } from './components/Banka/FetchBanke2'
import './custom.css'

var cols1: ColumnTip[] = [
    {
        name: 'Title',
        selector: 'title',
        sortable: true,
    } as ColumnTip,
    {
        name: 'Year',
        selector: 'year',
        sortable: true,
        right: true,
    } as ColumnTip
];

        //<Route path='/banka2/'
        //    render={(props) => (
        //        <FetchBanke2 {...props} cols={cols1} />
        //)}
export default () => (
    <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data/:startDateIndex?' component={FetchData} />
        <Route path='/banka/:startDateIndex?' component={FetchBanke} />

        <Route path='/banka2/' component={FetchBanke2} />

        />
    </Layout>
);
