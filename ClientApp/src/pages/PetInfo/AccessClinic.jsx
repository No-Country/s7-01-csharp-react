import React from "react";
import ClinicCard from "../Home/ClinicCard";

const AccessClinic = () => {
  return (
    <>
      <div className="flex gap-6 mt-4 ml-6">
        <button className="text-[13px]">Información Médica</button>
        <button className="text-[13px] text-primary-100  border-b-2 border-primary-100">
          Clínicas con acceso
        </button>
      </div>
      <div className="mt-11 flex gap-20 ml-2">
        <h3 className="ml-4 text-[18px] font-bold">Clínicas con acceso</h3>
      </div>
      <div className="mt-4 ">
        <p className="ml-6 text-[13px] mt-2 text-gray-150 mb-8">
          Estas son las clínicas veterinarias que pueden acceder a la
          información médica de tu mascota
        </p>
      </div>
      <ClinicCard/>
    </>
    
  );
};

export default AccessClinic;
