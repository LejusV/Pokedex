using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Mandibuzz Species to store common natural stats of all Mandibuzzs
	#region MandibuzzSpecies
	public class MandibuzzSpecies : PokemonSpecies
	{
#nullable enable
		private static MandibuzzSpecies? _instance = null;
#nullable restore
        public static MandibuzzSpecies Instance => _instance ?? (_instance = new MandibuzzSpecies());

		#region MandibuzzSpecies Constructor
		public MandibuzzSpecies() : base(
			630,
			"Mandibuzz",
			Dark.Instance, Flying.Instance,
			1.2,
			39.5,
			new PokemonStats(
				110, // HPs
				65, 105, // Attack & Defense
				55, 95, // Spacial Attack & Defense
				80 // Speed
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
				"Cut",
				"Gust",
				"Whirlwind",
				"Fly",
				"Fury-Attack",
				"Leer",
				"Hyper-Beam",
				"Toxic",
				"Double-Team",
				"Mirror-Move",
				"Sky-Attack",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Bone-Rush",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Flatter",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Punishment",
				"Dark-Pulse",
				"Air-Slash",
				"Brave-Bird",
				"Giga-Impact",
				"Nasty-Plot",
				"Defog",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}