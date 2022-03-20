using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Flygon Species to store common natural stats of all Flygons
	#region FlygonSpecies
	public class FlygonSpecies : PokemonSpecies
	{
#nullable enable
		private static FlygonSpecies? _instance = null;
#nullable restore
        public static FlygonSpecies Instance => _instance ?? (_instance = new FlygonSpecies());

		#region FlygonSpecies Constructor
		public FlygonSpecies() : base(
			330,
			"Flygon",
			Ground.Instance, Dragon.Instance,
			2.0,
			82.0,
			new PokemonStats(
				80, // HPs
				100, 80, // Attack & Defense
				80, 80, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Thunder-Punch",
				"Fly",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Sonic-Boom",
				"Flamethrower",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
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
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Air-Cutter",
				"Rock-Tomb",
				"Silver-Wind",
				"Signal-Beam",
				"Sand-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Giga-Impact",
				"Defog",
				"Draco-Meteor",
				"Stone-Edge",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Struggle-Bug",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}