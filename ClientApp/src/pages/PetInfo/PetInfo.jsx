import React from 'react'
import Navbar from '../../components/Layouts/Navbar'
import PetCard from './PetCard'
import RememberCards from '../Home/RememberCards'
import ClinicHistory from './ClinicHistory'
import VaccinationCard from './VaccinationCard'
import Medication from './Medication'
import AccessClinic from './AccessClinic'




const PetInfo = () => {
  return (
    <div className='container mx-auto'>
      <Navbar/>
      <PetCard/>
      <RememberCards/>
      <ClinicHistory/>
      <VaccinationCard/>
      <Medication/>  
      <AccessClinic/>      
    </div >
  )
}

export default PetInfo