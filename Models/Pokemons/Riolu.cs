using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Riolu Species to store common natural stats of all Riolus
	#region SpeciesRiolu
	public class SpeciesRiolu : PokemonSpecies
	{
#nullable enable
		private static SpeciesRiolu? _instance = null;
#nullable restore
        public static SpeciesRiolu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRiolu();
                }
                return _instance;
            }
        }

		#region SpeciesRiolu Constructor
		public SpeciesRiolu() : base(
			447,
			"Riolu",
			0.7,
			20.2,
			40, // HPs
			70, 40, // Attack & Defense
			35, 40, // Special Attack & Defense
			60		
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
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Headbutt",
				"Bite",
				"Roar",
				"Low-Kick",
				"Counter",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Screech",
				"Double-Team",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Reversal",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Cross-Chop",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Blaze-Kick",
				"Meteor-Mash",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Iron-Defense",
				"Bulk-Up",
				"Natural-Gift",
				"Feint",
				"Payback",
				"Fling",
				"Copycat",
				"Magnet-Rise",
				"Force-Palm",
				"Poison-Jab",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Nasty-Plot",
				"Bullet-Punch",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Circle-Throw",
				"Retaliate",
				"Final-Gambit",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Riolu PokemonInstance Class
	#region Riolu
	public class RioluInstance : PokemonInstance
	{
		#region Riolu Constructors
		/// <summary>
		/// Riolu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RioluInstance(string nickname, int level)
		: base(
				SpeciesRiolu.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Riolu Builder only waiting for a Level
		/// </summary>
		public RioluInstance(int level)
		: base(
				SpeciesRiolu.Instance, // PokemonInstance Species
				"Riolu", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Riolu Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public RioluInstance() : base(
			SpeciesRiolu.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}