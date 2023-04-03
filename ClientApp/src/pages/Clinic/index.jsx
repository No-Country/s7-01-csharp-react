import { CoverClinic } from "../../components/CoverClinic";
import { DataClinic } from "../../components/DataClinic";
import { ContactClinic } from "../../components/ContactClinic";
import { InfoClinic } from "../../components/InfoClinic";

export function Clinic() {
  return (
    <>
      <CoverClinic />
      {/* <main className="flex flex-col gap">

      </main> */}
      <DataClinic />
      <ContactClinic />
      <InfoClinic />
    </>
  );
}
