import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import PetCard from '../PetInfo/PetCard'
import ClinicHistory from '../PetInfo/ClinicHistory'
import VaccinationCard from '../PetInfo/VaccinationCard'
import Medication from '../PetInfo/Medication'
import ThirdBlock from './ThirdBlock'

const PetInfoVet = () => {
    return (
        <div className='mx-auto container'>
            <Navbar />
            <PetCard />
            <ThirdBlock />
            <VaccinationCard />
            <Medication />
        </div>
    )
}

export default PetInfoVet