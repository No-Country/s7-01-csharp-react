import React from "react";

<<<<<<< HEAD
const Medication = () => {
  return (
    <>
      <div className="ml-4 w-[360px] h-[50px] flex justify-between ">
        <h1 className="text-[18px] font-bold">Tratamiento y medicación</h1>
      </div>
      <div className=" h-[120px] w-[373px] ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg bg-white">
        <h1 className="font-bold ml-5 mt-2">{"{tipo de tratamiento}"}</h1>
        <p className="ml-5  text-[13px]">Fecha de inicio:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]">Fecha de finalización:{"{fecha}"}</p>
        <p className="ml-5 text-[13px]"> Próxima vacunación:{"{fecha}"}</p>
      </div>
      <p className="text-gray-150 text-[11px] text-end mt-2 mb-10 mr-2 md:text-start md:ml-24">
        ACTUALIZADO POR"{"NOMBRE DE LA CLINICA"} EL 21/2/23"
      </p>
    </>
=======
import { myFecha } from "../../utils/fecha";

const Medication = ({ tratamiento }) => {
  console.log("🚀 ~ file: Medication.jsx:6 ~ Medication ~ trata:", tratamiento);

  return (
    <div className="w-full flex flex-col gap-1">
      <div className="ml-4 mr-4  mt-2 flex flex-col gap-2 rounded-lg bg-white p-2">
        <h1 className="font-bold ml-5 mt-2">{tratamiento.tipoTratamiento}</h1>
        <p className="ml-5  text-[13px]">
          Fecha de dosificación: {myFecha(tratamiento.fecha)}
        </p>
        <div className="ml-5 text-[13px]">
          Observaciones:
          <p>{tratamiento.observaciones}</p>
        </div>
        <p className="ml-5  text-[13px]">{tratamiento.nombreMedico}</p>
      </div>
      <p className="text-black text-[11px] text-end mt-2 mb-10 mr-2 md:text-start md:ml-60">
        ACTUALIZADO EL {myFecha(tratamiento.fecha)}
      </p>
    </div>
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
  );
};

export default Medication;
