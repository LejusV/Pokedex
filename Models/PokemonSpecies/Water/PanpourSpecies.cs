using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Panpour Species to store common natural stats of all Panpours
	#region PanpourSpecies
	public class PanpourSpecies : PokemonSpecies
	{
#nullable enable
		private static PanpourSpecies? _instance = null;
#nullable restore
        public static PanpourSpecies Instance => _instance ?? (_instance = new PanpourSpecies());

		#region PanpourSpecies Constructor
		public PanpourSpecies() : base(
			515,
			"Panpour",
			Water.Instance,
			0.6,
			13.5,
			new PokemonStats(
				50, // HPs
				53, 48, // Attack & Defense
				53, 48, // Spacial Attack & Defense
				64 // Speed
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
				"Ice-Punch",
				"Scratch",
				"Cut",
				"Leer",
				"Bite",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Waterfall",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Recycle",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Dive",
				"Mud-Sport",
				"Astonish",
				"Rock-Tomb",
				"Tickle",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Aqua-Ring",
				"Aqua-Tail",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Low-Sweep",
				"Round",
				"Scald",
				"Acrobatics",
				"Water-Pledge",
				"Work-Up",
				"Disarming-Voice",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}