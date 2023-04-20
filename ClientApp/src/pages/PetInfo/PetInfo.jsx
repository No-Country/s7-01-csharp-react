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
  const { pet } = usePet();
  console.log("🚀 ~ file: PetInfo.jsx:15 ~ PetInfo ~ pet:", pet);

  return (
    <>
      <Navbar />
      <div className="container mx-auto">
        <PetCard pet={pet} />
        <ClinicHistory />
        <div className="flex flex-col md:flex-row justify-start gap-8 md:p-6">
          <div className="w-full md:w-5/12">
            <h2 className="font-bold text-lg"> Tratamientos</h2>
            <Medication />
          </div>

          <div className="w-full md:w-5/12">
            <h2 className="font-bold text-lg"> Vacunación</h2>
            <VaccinationCard />
          </div>
        </div>
      </div>
    </>
  );
};

export default PetInfo;
