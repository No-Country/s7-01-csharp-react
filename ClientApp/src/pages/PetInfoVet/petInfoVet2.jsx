import { usePet } from "../../hooks/usePet";
import Navbar from "../../components/Layouts/Navbar";
import PetCard from "../PetInfo/PetCard";
import ClinicHistory from "../PetInfo/ClinicHistory";
import Medication from "../PetInfo/Medication";
import VaccinationCard from "../PetInfo/VaccinationCard";
import ThirdBlock from "./ThirdBlock";

const PetInfoVet2 = () => {
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
        <ThirdBlock />
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

export default PetInfoVet2;
