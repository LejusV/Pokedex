using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Heatran Species to store common natural stats of all Heatrans
	#region HeatranSpecies
	public class HeatranSpecies : PokemonSpecies
	{
#nullable enable
		private static HeatranSpecies? _instance = null;
#nullable restore
        public static HeatranSpecies Instance => _instance ?? (_instance = new HeatranSpecies());

		#region HeatranSpecies Constructor
		public HeatranSpecies() : base(
			485,
			"Heatran",
			Fire.Instance, Steel.Instance,
			1.7,
			430.0,
			new PokemonStats(
				91, // HPs
				90, 106, // Attack & Defense
				130, 106, // Spacial Attack & Defense
				77 // Speed
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
				"Headbutt",
				"Leer",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Taunt",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Metal-Sound",
				"Iron-Defense",
				"Natural-Gift",
				"Payback",
				"Dark-Pulse",
				"Dragon-Pulse",
				"Earth-Power",
				"Giga-Impact",
				"Fire-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Bug-Bite",
				"Magma-Storm",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}