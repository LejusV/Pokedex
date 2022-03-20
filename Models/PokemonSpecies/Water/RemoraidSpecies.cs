using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Remoraid Species to store common natural stats of all Remoraids
	#region RemoraidSpecies
	public class RemoraidSpecies : PokemonSpecies
	{
#nullable enable
		private static RemoraidSpecies? _instance = null;
#nullable restore
        public static RemoraidSpecies Instance => _instance ?? (_instance = new RemoraidSpecies());

		#region RemoraidSpecies Constructor
		public RemoraidSpecies() : base(
			223,
			"Remoraid",
			Water.Instance,
			0.6,
			12.0,
			new PokemonStats(
				35, // HPs
				65, 35, // Attack & Defense
				65, 35, // Spacial Attack & Defense
				65 // Speed
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
				"Double-Edge",
				"Supersonic",
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
				"String-Shot",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Haze",
				"Focus-Energy",
				"Fire-Blast",
				"Waterfall",
				"Swift",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Octazooka",
				"Icy-Wind",
				"Lock-On",
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
				"Water-Spout",
				"Signal-Beam",
				"Bullet-Seed",
				"Bounce",
				"Mud-Shot",
				"Rock-Blast",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Seed-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Charge-Beam",
				"Smack-Down",
				"Soak",
				"Acid-Spray",
				"Entrainment",
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