import React from "react";
import { Link, useNavigate } from "react-router-dom";
import { addMascotaVeterinary } from "../../services/addMascotaVeterinary";

const ThirdBlock = ({ mascotas }) => {
  let navigate = useNavigate()
  if (!mascotas) {
    return <div></div>;
  }
  const handleClick = async (m)=>{
    let response = await addMascotaVeterinary(1, m.id)
    navigate('/app/veterinary')
  }
  return (
    <div className="mt-4 block md:grid md:grid-cols-4 md:justify-between md:gap-x-16 md:gap-y-2">
      {mascotas.map((m) => (
        <div
          key={m.id}
          className="w-[300px] h-[215px] mt-4 flex justify-center flex-col text-center rounded-xl md:w-[330px] md:h-[215px]   bg-white mx-auto"
        >
          <img
            src={m.urlFotoPerfil}
            alt="fotoperro"
            className="w-12 h-12 mx-auto rounded-full"
          />
          <p>{m.nombre}</p>
          <p>{m.especie}</p>
          <button type="submit" className="w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2"  onClick={()=> handleClick(m)} >
            <p className="text-primary-100">Añadir Paciente</p>
          </button>
        </div>
      ))}
    </div>
  );
};

export default ThirdBlock;
