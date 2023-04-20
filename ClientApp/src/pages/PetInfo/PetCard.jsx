import React from "react";
import imgPerro from "../../assets/images/imgPerro.png";

const PetCard = ({ pet }) => {
  return (
    <>
      <div className="mt-4 w-[328px] h-[275px] ml-4 ">
        <img
          src={pet.urlFotoPerfil}
          alt="perro"
          className="mt-6 rounded-full object-cover object-center"
        />

        <p className="mt-2 text-[24px]">{pet.nombre}</p>
        <p className="mt-2 text-gray-150">
          {pet.especie}-{pet.sexo}
        </p>
      </div>
    </>
  );
};

export default PetCard;
