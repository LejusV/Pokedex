using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Garchomp Species to store common natural stats of all Garchomps
	#region GarchompSpecies
	public class GarchompSpecies : PokemonSpecies
	{
#nullable enable
		private static GarchompSpecies? _instance = null;
#nullable restore
        public static GarchompSpecies Instance => _instance ?? (_instance = new GarchompSpecies());

		#region GarchompSpecies Constructor
		public GarchompSpecies() : base(
			445,
			"Garchomp",
			Dragon.Instance, Ground.Instance,
			1.9,
			95.0,
			new PokemonStats(
				108, // HPs
				130, 95, // Attack & Defense
				80, 85, // Spacial Attack & Defense
				102 // Speed
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
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Surf",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Natural-Gift",
				"Fling",
				"Poison-Jab",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Rock-Climb",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Dual-Chop",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}