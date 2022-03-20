using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shelgon Species to store common natural stats of all Shelgons
	#region ShelgonSpecies
	public class ShelgonSpecies : PokemonSpecies
	{
#nullable enable
		private static ShelgonSpecies? _instance = null;
#nullable restore
        public static ShelgonSpecies Instance => _instance ?? (_instance = new ShelgonSpecies());

		#region ShelgonSpecies Constructor
		public ShelgonSpecies() : base(
			372,
			"Shelgon",
			Dragon.Instance,
			1.1,
			110.5,
			new PokemonStats(
				65, // HPs
				95, 100, // Attack & Defense
				60, 50, // Spacial Attack & Defense
				50 // Speed
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Natural-Gift",
				"Dragon-Pulse",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Captivate",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}