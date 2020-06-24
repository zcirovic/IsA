import * as React from 'react';
import { useState } from 'react';
import * as Btip from './FetchBanka2Types'


export interface BankaData {
    Id: number;
    naziv: string;
    mesto: string;
    adresa: string;
}
interface ReadingData {
    status: string;
    data: BankaData;
}
export interface BankaDataS {
    result: BankaData[];
}

var x: BankaData;
x = {
    Id: -1,
    adresa: '-',
    naziv: '-',
    mesto: '-',
}

const FatchBanka2Service = () => {
    const [result, setResult] = useState<ReadingData>(
        {
            status: "loading",
            data:  {
                Id : -1,
                adresa : '-',
                naziv : '-',
                mesto : '-',
            }
        }
    );
    console.log("radi useeffect");
    React.useEffect(() => {
        fetch('http://localhost:11477/banka/5')
            .then(response => console.log(response))
            .then(response => response)
            .then(response => setResult({ status: 'ok', data: response.json() as BankaData }))
            .catch(error => setResult({ status: 'error', data: x }));
    }, []);
    
    return result;
};

export default FatchBanka2Service;