import React from "react";

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
  );
};

export default Medication;
