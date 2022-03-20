using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Salamence Species to store common natural stats of all Salamences
	#region SalamenceSpecies
	public class SalamenceSpecies : PokemonSpecies
	{
#nullable enable
		private static SalamenceSpecies? _instance = null;
#nullable restore
        public static SalamenceSpecies Instance => _instance ?? (_instance = new SalamenceSpecies());

		#region SalamenceSpecies Constructor
		public SalamenceSpecies() : base(
			373,
			"Salamence",
			Dragon.Instance, Flying.Instance,
			1.5,
			102.6,
			new PokemonStats(
				95, // HPs
				135, 80, // Attack & Defense
				110, 80, // Spacial Attack & Defense
				100 // Speed
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
				"Fly",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Focus-Energy",
				"Fire-Blast",
				"Swift",
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
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Defog",
				"Draco-Meteor",
				"Stone-Edge",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}