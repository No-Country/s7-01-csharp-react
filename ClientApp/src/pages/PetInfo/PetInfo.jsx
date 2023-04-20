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
    <div className="container mx-auto">
      <Navbar />
      <PetCard pet={pet} />
      <ClinicHistory />
      <VaccinationCard />
      <Medication />
    </div>
  );
};

export default PetInfo;
