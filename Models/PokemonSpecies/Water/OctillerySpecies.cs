using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Octillery Species to store common natural stats of all Octillerys
	#region OctillerySpecies
	public class OctillerySpecies : PokemonSpecies
	{
#nullable enable
		private static OctillerySpecies? _instance = null;
#nullable restore
        public static OctillerySpecies Instance => _instance ?? (_instance = new OctillerySpecies());

		#region OctillerySpecies Constructor
		public OctillerySpecies() : base(
			224,
			"Octillery",
			Water.Instance,
			0.9,
			28.5,
			new PokemonStats(
				75, // HPs
				105, 75, // Attack & Defense
				105, 75, // Spacial Attack & Defense
				45 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Bind",
				"Double-Edge",
				"Flamethrower",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Bubble-Beam",
				"Aurora-Beam",
				"Hyper-Beam",
				"Seismic-Toss",
				"String-Shot",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Constrict",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Octazooka",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Whirlpool",
				"Facade",
				"Secret-Power",
				"Dive",
				"Signal-Beam",
				"Bullet-Seed",
				"Bounce",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Wring-Out",
				"Seed-Bomb",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Gunk-Shot",
				"Captivate",
				"Charge-Beam",
				"Smack-Down",
				"Sludge-Wave",
				"Soak",
				"Round",
				"Scald",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}