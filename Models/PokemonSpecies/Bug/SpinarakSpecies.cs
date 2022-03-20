using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Spinarak Species to store common natural stats of all Spinaraks
	#region SpinarakSpecies
	public class SpinarakSpecies : PokemonSpecies
	{
#nullable enable
		private static SpinarakSpecies? _instance = null;
#nullable restore
        public static SpinarakSpecies Instance => _instance ?? (_instance = new SpinarakSpecies());

		#region SpinarakSpecies Constructor
		public SpinarakSpecies() : base(
			167,
			"Spinarak",
			Bug.Instance, Poison.Instance,
			0.5,
			8.5,
			new PokemonStats(
				40, // HPs
				60, 40, // Attack & Defense
				40, 40, // Spacial Attack & Defense
				30 // Speed
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
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Twineedle",
				"Pin-Missile",
				"Sonic-Boom",
				"Disable",
				"Psybeam",
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
				"Megahorn",
				"Baton-Pass",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Natural-Gift",
				"Sucker-Punch",
				"Toxic-Spikes",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Shadow-Sneak",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Rage-Powder",
				"Foul-Play",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Sticky-Web",
				"Confide",
				"Infestation",
				"Toxic-Thread",
				"Lunge"
			};
		}
		#endregion
	}
	#endregion
}