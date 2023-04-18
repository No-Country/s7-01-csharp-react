import React from "react";
import { MagnifyingGlass } from "@phosphor-icons/react";
import MiniClinic from "./MiniClinic";
import { useAllClinics } from "../../hooks/useAllClinics";

// rutas
import { Link } from "react-router-dom";

const ClinicCard = () => {
  const { clinicas, services } = useAllClinics();

  return (
    <div className="container mx-auto">
      <div className="mt-8 px-2 ">
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
      <div className="grid grid-cols-2 md:flex md:flex-row md:justify-start  gap-4 justify-between mt-4 container">
        {services.map((service) => (
          <button
            key={service.id}
            className="bg-primary-150 rounded-xl px-2 py-1"
          >
            {service.nombre}
          </button>
        ))}
      </div>

      <div className="container mt-8 mx-auto h-screen  grid md:grid-cols-2 lg:grid-cols-3 md:gap-8">
        {clinicas.map((clinica) => (
          <Link to={`app/clinic`}>
            <MiniClinic key={clinica.id} nombre={clinica.nombre} />
          </Link>
        ))}
      </div>
    </div>
  );
};

export default ClinicCard;
