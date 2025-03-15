import { useEffect, useState } from "react";

interface Bowler {
  bowlerId: number;
  firstName: string;
  middleInit?: string | null;
  lastName: string;
  address?: string;
  city?: string;
  state?: string;
  zip?: string;
  phoneNumber?: string;
  teamName: string;
}

function BowlerList() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);

  useEffect(() => {
    fetch("https://localhost:5000/api/Bowler")
      .then((response) => response.json())
      .then((data) => setBowlers(data))
      .catch((error) => console.error("Error fetching data:", error));
  }, []);

  return (
    <div className="container">
        <h2>Bowler List</h2>
        <table>
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Team</th>
                    <th>City</th>
                    <th>State</th>
                    <th>Phone</th>
                </tr>
            </thead>
            <tbody>
                {bowlers.map((bowler) => (
                    <tr key={bowler.bowlerId}>
                        <td>{`${bowler.firstName} ${bowler.lastName}`}</td>
                        <td>{bowler.teamName}</td>
                        <td>{bowler.city}</td>
                        <td>{bowler.state}</td>
                        <td>{bowler.phoneNumber}</td>
                    </tr>
                ))}
            </tbody>
        </table>
    </div>
);


}

export default BowlerList;
