import React from "react";

const Medication = () => {
  return (
    <>
      <div className="ml-4 w-[360px] h-[50px] flex justify-between ">
        <h1 className="text-[18px] font-bold">Tratamiento y medicación</h1>
      </div>
      <div className=" h-[120px] ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg">
        <h1 className="font-bold ml-5 mt-2">{"{tipo de tratamiento}"}</h1>
        <p className="ml-5  text-[13px]">Fecha de inicio:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]">Fecha de finalización:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]"> Próxima vacunación:{"{fecha}"}</p>
      </div>
      <p className="text-gray-150 text-[11px] text-end mt-2 mb-10 mr-2">
        ACTUALIZADO POR"{"NOMBRE DE LA CLINICA"} EL 21/2/23"
      </p>
    </>
  );
};

export default Medication;
