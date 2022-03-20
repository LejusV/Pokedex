using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bagon Species to store common natural stats of all Bagons
	#region BagonSpecies
	public class BagonSpecies : PokemonSpecies
	{
#nullable enable
		private static BagonSpecies? _instance = null;
#nullable restore
        public static BagonSpecies Instance => _instance ?? (_instance = new BagonSpecies());

		#region BagonSpecies Constructor
		public BagonSpecies() : base(
			371,
			"Bagon",
			Dragon.Instance,
			0.6,
			42.1,
			new PokemonStats(
				45, // HPs
				75, 60, // Attack & Defense
				40, 30, // Spacial Attack & Defense
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
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hydro-Pump",
				"Strength",
				"Dragon-Rage",
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
				"Dragon-Claw",
				"Dragon-Dance",
				"Natural-Gift",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Shadow-Claw",
				"Fire-Fang",
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