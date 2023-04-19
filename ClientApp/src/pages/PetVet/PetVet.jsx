import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import FirstBlock from '../PetVet/FirstBlock'
import SecondBlock from './SecondBlock'
import ThirdBlock from './ThirdBlock'

const PetVet = () => {
    return (
        <div className='container mx-auto'>
            <Navbar />
            <FirstBlock />
            <SecondBlock/>
            <ThirdBlock />
           
        </div>
    )
}

export default PetVet