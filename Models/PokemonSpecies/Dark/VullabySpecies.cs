using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vullaby Species to store common natural stats of all Vullabys
	#region VullabySpecies
	public class VullabySpecies : PokemonSpecies
	{
#nullable enable
		private static VullabySpecies? _instance = null;
#nullable restore
        public static VullabySpecies Instance => _instance ?? (_instance = new VullabySpecies());

		#region VullabySpecies Constructor
		public VullabySpecies() : base(
			629,
			"Vullaby",
			Dark.Instance, Flying.Instance,
			0.5,
			9.0,
			new PokemonStats(
				70, // HPs
				55, 75, // Attack & Defense
				45, 65, // Spacial Attack & Defense
				60 // Speed
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
				"Toxic",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Swagger",
				"Steel-Wing",
				"Mean-Look",
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
				"Fake-Tears",
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