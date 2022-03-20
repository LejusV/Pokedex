using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Dodrio Species to store common natural stats of all Dodrios
	#region DodrioSpecies
	public class DodrioSpecies : PokemonSpecies
	{
#nullable enable
		private static DodrioSpecies? _instance = null;
#nullable restore
        public static DodrioSpecies Instance => _instance ?? (_instance = new DodrioSpecies());

		#region DodrioSpecies Constructor
		public DodrioSpecies() : base(
			85,
			"Dodrio",
			Normal.Instance, Flying.Instance,
			1.8,
			85.2,
			new PokemonStats(
				60, // HPs
				110, 70, // Attack & Defense
				60, 60, // Spacial Attack & Defense
				110 // Speed
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
				"Swords-Dance",
				"Whirlwind",
				"Fly",
				"Jump-Kick",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Swift",
				"Skull-Bash",
				"Sky-Attack",
				"Rest",
				"Tri-Attack",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Air-Cutter",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Acupressure",
				"Payback",
				"Giga-Impact",
				"Captivate",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}