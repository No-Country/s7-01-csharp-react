import React, { useEffect, useState } from 'react'
import Navbar from '../../components/Layouts/Navbar'
import FirstBlock from '../PetVet/FirstBlock'
import SecondBlock from './SecondBlock'
import ThirdBlock from './ThirdBlock'
import { useParams } from 'react-router-dom'
import { getPropMasc } from '../../services/getPropMasc'

const PetVet = () => {
    const [Data, setData] = useState(null);
    const [Mascotas, setMascotas] = useState(null);
    const {id} = useParams()
    const getApi = async ()=>{
        let response = await getPropMasc(id)
        setData(response.prop)
        setMascotas(response.mascota)
    }
    useEffect(() => {
        getApi()
    }, []);
    return (
        <div className='container mx-auto'>
            <Navbar />
            <FirstBlock prop={Data} />
            <SecondBlock nombre={Data?.nombre}/>
            <ThirdBlock mascotas={Mascotas}/>
           
        </div>
    )
}

export default PetVet