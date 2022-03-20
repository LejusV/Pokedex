using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Trapinch Species to store common natural stats of all Trapinchs
	#region TrapinchSpecies
	public class TrapinchSpecies : PokemonSpecies
	{
#nullable enable
		private static TrapinchSpecies? _instance = null;
#nullable restore
        public static TrapinchSpecies Instance => _instance ?? (_instance = new TrapinchSpecies());

		#region TrapinchSpecies Constructor
		public TrapinchSpecies() : base(
			328,
			"Trapinch",
			Ground.Instance,
			0.7,
			15.0,
			new PokemonStats(
				45, // HPs
				100, 45, // Attack & Defense
				45, 45, // Spacial Attack & Defense
				10 // Speed
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
				"Gust",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Quick-Attack",
				"Mimic",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Sandstorm",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Secret-Power",
				"Rock-Tomb",
				"Signal-Beam",
				"Sand-Tomb",
				"Mud-Shot",
				"Natural-Gift",
				"Feint",
				"Earth-Power",
				"Captivate",
				"Bug-Bite",
				"Round",
				"Struggle-Bug",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}