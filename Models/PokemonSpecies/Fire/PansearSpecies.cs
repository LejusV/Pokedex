using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pansear Species to store common natural stats of all Pansears
	#region PansearSpecies
	public class PansearSpecies : PokemonSpecies
	{
#nullable enable
		private static PansearSpecies? _instance = null;
#nullable restore
        public static PansearSpecies Instance => _instance ?? (_instance = new PansearSpecies());

		#region PansearSpecies Constructor
		public PansearSpecies() : base(
			513,
			"Pansear",
			Fire.Instance,
			0.6,
			11.0,
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
				"Fire-Punch",
				"Scratch",
				"Cut",
				"Leer",
				"Bite",
				"Flamethrower",
				"Low-Kick",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Amnesia",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Astonish",
				"Overheat",
				"Rock-Tomb",
				"Tickle",
				"Covet",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Gastro-Acid",
				"Flare-Blitz",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Belch",
				"Disarming-Voice",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}