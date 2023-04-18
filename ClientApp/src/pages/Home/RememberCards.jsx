import React from "react";
import MiniCards from "./MiniCards";


const RememberCards = () => {

  return (
    <div className="container mx-auto">
      <div className="mt-6 p-2  ">
        <h3 className="ml-2 text-[18px] font-bold ">
          Proximos Recordatorios (3)
        </h3>
      </div>      
      <div className="grid grid-cols-1 md:grid md:grid-cols-4">
        <MiniCards />
        <MiniCards />
        <MiniCards />          
        
      </div>

    </div>
  );
};

export default RememberCards;
