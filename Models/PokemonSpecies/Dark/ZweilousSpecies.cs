using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zweilous Species to store common natural stats of all Zweilouss
	#region ZweilousSpecies
	public class ZweilousSpecies : PokemonSpecies
	{
#nullable enable
		private static ZweilousSpecies? _instance = null;
#nullable restore
        public static ZweilousSpecies Instance => _instance ?? (_instance = new ZweilousSpecies());

		#region ZweilousSpecies Constructor
		public ZweilousSpecies() : base(
			634,
			"Zweilous",
			Dark.Instance, Dragon.Instance,
			1.4,
			50.0,
			new PokemonStats(
				72, // HPs
				85, 70, // Attack & Defense
				65, 70, // Spacial Attack & Defense
				58 // Speed
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
				"Slam",
				"Headbutt",
				"Body-Slam",
				"Bite",
				"Roar",
				"Strength",
				"Dragon-Rage",
				"Thunder-Wave",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Superpower",
				"Secret-Power",
				"Hyper-Voice",
				"Shock-Wave",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Double-Hit",
				"Round",
				"Incinerate",
				"Dragon-Tail",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}