import React from "react";

const ThirdBlock = ({ mascotas }) => {
  if (!mascotas) {
    return <div></div>;
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
          <button className="w-[191px] h-[48px] mt-2 mx-auto px-4 py-3 rounded-md border-primary-100 border bg-gray-50 flex justify-center gap-2">
            <p className="text-primary-100">Añadir Paciente</p>
          </button>
        </div>
      ))}
    </div>
  );
};

export default ThirdBlock;
