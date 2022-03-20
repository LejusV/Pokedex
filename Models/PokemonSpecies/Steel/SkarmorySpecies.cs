using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Skarmory Species to store common natural stats of all Skarmorys
	#region SkarmorySpecies
	public class SkarmorySpecies : PokemonSpecies
	{
#nullable enable
		private static SkarmorySpecies? _instance = null;
#nullable restore
        public static SkarmorySpecies Instance => _instance ?? (_instance = new SkarmorySpecies());

		#region SkarmorySpecies Constructor
		public SkarmorySpecies() : base(
			227,
			"Skarmory",
			Steel.Instance, Flying.Instance,
			1.7,
			50.5,
			new PokemonStats(
				65, // HPs
				80, 140, // Attack & Defense
				40, 70, // Spacial Attack & Defense
				70 // Speed
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
				"Cut",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Fury-Attack",
				"Double-Edge",
				"Leer",
				"Roar",
				"Peck",
				"Drill-Peck",
				"Counter",
				"Toxic",
				"Agility",
				"Mimic",
				"Double-Team",
				"Swift",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Spikes",
				"Icy-Wind",
				"Detect",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Metal-Claw",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Pluck",
				"Tailwind",
				"Payback",
				"Assurance",
				"Guard-Swap",
				"Dark-Pulse",
				"Night-Slash",
				"Air-Slash",
				"X-Scissor",
				"Brave-Bird",
				"Flash-Cannon",
				"Defog",
				"Iron-Head",
				"Captivate",
				"Stealth-Rock",
				"Ominous-Wind",
				"Autotomize",
				"Round",
				"Sky-Drop",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}