import React from "react";
import { MagnifyingGlass } from "@phosphor-icons/react";
import MiniClinic from "./MiniClinic";
import { useAllClinics } from "../../hooks/useAllClinics";

// rutas
import { Link } from "react-router-dom";

const ClinicCard = () => {
  const { clinicas, services } = useAllClinics();
  // console.log(clinicas);
  return (
    <div className="container mx-auto my-8 ">
      <div className="px-2 ">
        <h3 className="mt-4 font-bold">Clínicas Veterinarias</h3>
        <div className="mt-4 w-[328px] h-[40px] md:w-[900px] md:h-[21px] rounded-xl  flex items-center gap-2">
          <MagnifyingGlass size={20} />
          <input
            type="text"
            className=" w-[280px] h-[21px] md:w-[900px] md:h-[21px] rounded-md p-4 "
            placeholder="Buscar Veterinarias"
          />
        </div>
      </div>
      <div className="container mt-8 mx-auto grid gap-4 gap-x-16 justify-center md:grid-cols-2 lg:grid-cols-3">
        {clinicas.map((clinica) => (
          <MiniClinic key={clinica.id} clinica={clinica} />
        ))}
      </div>
    </div>
  );
};

export default ClinicCard;
