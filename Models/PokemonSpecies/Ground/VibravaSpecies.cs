using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Vibrava Species to store common natural stats of all Vibravas
	#region VibravaSpecies
	public class VibravaSpecies : PokemonSpecies
	{
#nullable enable
		private static VibravaSpecies? _instance = null;
#nullable restore
        public static VibravaSpecies Instance => _instance ?? (_instance = new VibravaSpecies());

		#region VibravaSpecies Constructor
		public VibravaSpecies() : base(
			329,
			"Vibrava",
			Ground.Instance, Dragon.Instance,
			1.1,
			15.3,
			new PokemonStats(
				50, // HPs
				70, 50, // Attack & Defense
				50, 50, // Spacial Attack & Defense
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
				"Fly",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Supersonic",
				"Sonic-Boom",
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
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Dragon-Pulse",
				"Earth-Power",
				"Defog",
				"Draco-Meteor",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}