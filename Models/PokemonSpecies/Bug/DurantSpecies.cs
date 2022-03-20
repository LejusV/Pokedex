using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Durant Species to store common natural stats of all Durants
	#region DurantSpecies
	public class DurantSpecies : PokemonSpecies
	{
#nullable enable
		private static DurantSpecies? _instance = null;
#nullable restore
        public static DurantSpecies Instance => _instance ?? (_instance = new DurantSpecies());

		#region DurantSpecies Constructor
		public DurantSpecies() : base(
			632,
			"Durant",
			Bug.Instance, Steel.Instance,
			0.3,
			33.0,
			new PokemonStats(
				58, // HPs
				109, 112, // Attack & Defense
				48, 48, // Spacial Attack & Defense
				109 // Speed
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
				"Vice-Grip",
				"Guillotine",
				"Cut",
				"Sand-Attack",
				"Bite",
				"Strength",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Metal-Claw",
				"Hidden-Power",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Rock-Polish",
				"X-Scissor",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Thunder-Fang",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Bug-Bite",
				"Hone-Claws",
				"Entrainment",
				"Round",
				"Retaliate",
				"Struggle-Bug",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}