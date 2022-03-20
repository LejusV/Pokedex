using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Huntail Species to store common natural stats of all Huntails
	#region HuntailSpecies
	public class HuntailSpecies : PokemonSpecies
	{
#nullable enable
		private static HuntailSpecies? _instance = null;
#nullable restore
        public static HuntailSpecies Instance => _instance ?? (_instance = new HuntailSpecies());

		#region HuntailSpecies Constructor
		public HuntailSpecies() : base(
			367,
			"Huntail",
			Water.Instance,
			1.7,
			27.0,
			new PokemonStats(
				55, // HPs
				104, 105, // Attack & Defense
				94, 75, // Spacial Attack & Defense
				52 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Waterfall",
				"Swift",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Whirlpool",
				"Hail",
				"Facade",
				"Snatch",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Sucker-Punch",
				"Aqua-Tail",
				"Giga-Impact",
				"Ice-Fang",
				"Captivate",
				"Coil",
				"Round",
				"Scald",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}