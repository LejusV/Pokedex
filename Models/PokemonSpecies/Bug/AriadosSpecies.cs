using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ariados Species to store common natural stats of all Ariadoss
	#region AriadosSpecies
	public class AriadosSpecies : PokemonSpecies
	{
#nullable enable
		private static AriadosSpecies? _instance = null;
#nullable restore
        public static AriadosSpecies Instance => _instance ?? (_instance = new AriadosSpecies());

		#region AriadosSpecies Constructor
		public AriadosSpecies() : base(
			168,
			"Ariados",
			Bug.Instance, Poison.Instance,
			1.1,
			33.5,
			new PokemonStats(
				70, // HPs
				90, 70, // Attack & Defense
				60, 70, // Spacial Attack & Defense
				40 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Psychic",
				"Agility",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Constrict",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Spider-Web",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Natural-Gift",
				"Sucker-Punch",
				"Poison-Jab",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Sneak",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Foul-Play",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Sticky-Web",
				"Fell-Stinger",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Toxic-Thread",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}