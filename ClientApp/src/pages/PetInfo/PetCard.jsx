import React from "react";
import imgPerro from "../../assets/images/imgPerro.png";

const PetCard = ({ pet }) => {
  // console.log("🚀 ~ file: PetCard.jsx:5 ~ PetCard ~ pet:", pet);

  return (
    <div className="flex flex-row justify-start items-center gap-6 p-6 mt-4 w-10/12  ml-4 bg-white">
      <img
        src={pet.urlFotoPerfil}
        alt="perro"
        className="mt-6 rounded-full object-cover object-center"
      />
      <div>
        <p className="mt-2 text-gray-150">{pet.especie}</p>
        <p className="mt-2 text-[24px]">{pet.nombre}</p>
        <p className="mt-2 text-gray-150">
          {pet.sexo} - {pet.peso}kg
        </p>
      </div>
    </div>
  );
};

export default PetCard;
