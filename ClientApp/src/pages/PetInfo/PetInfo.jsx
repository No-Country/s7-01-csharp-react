<<<<<<< HEAD
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
=======
import React from "react";
import Navbar from "../../components/Layouts/Navbar";
import PetCard from "./PetCard";
import RememberCards from "../Home/RememberCards";
import ClinicHistory from "./ClinicHistory";
import VaccinationCard from "./VaccinationCard";
import Medication from "./Medication";
import AccessClinic from "./AccessClinic";

// custom hook
import { usePet } from "../../hooks/usePet";

const PetInfo = () => {
  const { pet, tratamientos, vacunas } = usePet();
  console.log("🚀 ~ file: PetInfo.jsx:15 ~ PetInfo ~ vacunas:", vacunas);
  console.log(
    "🚀 ~ file: PetInfo.jsx:15 ~ PetInfo ~ tratamientos:",
    tratamientos
  );
  // console.log("🚀 ~ file: PetInfo.jsx:15 ~ PetInfo ~ pet:", pet);

  return (
    <>
      <Navbar />
      <div className="container mx-auto">
        <PetCard pet={pet} />
        <ClinicHistory />
        <div className="flex flex-col md:flex-row justify-start gap-8 md:p-6">
          <div className="w-full md:w-5/12">
            <h2 className="font-bold text-lg"> Tratamientos</h2>
            {[...tratamientos].reverse().map((trata) => (
              <Medication key={trata.tipoTratamiento} tratamiento={trata} />
            ))}
          </div>

          <div className="w-full md:w-5/12">
            <h2 className="font-bold text-lg"> Vacunación</h2>
            {[...vacunas].reverse().map((vacu) => (
              <VaccinationCard key={vacu.id} vacuna={vacu} />
            ))}
          </div>
        </div>
      </div>
    </>
  );
};

export default PetInfo;
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
