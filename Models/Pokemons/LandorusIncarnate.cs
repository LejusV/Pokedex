using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Landorus-Incarnate Species to store common natural stats of all Landorus-Incarnates
	#region SpeciesLandorus-Incarnate
	public class SpeciesLandorusIncarnate : PokemonSpecies
	{
#nullable enable
		private static SpeciesLandorusIncarnate? _instance = null;
#nullable restore
        public static SpeciesLandorusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLandorusIncarnate();
                }
                return _instance;
            }
        }

		#region SpeciesLandorus-Incarnate Constructor
		public SpeciesLandorusIncarnate() : base(
			"Landorus-Incarnate",
			1.5,
			68.0,
			89, // HPs
			125, 90, // Attack & Defense
			115, 80, // Special Attack & Defense
			101		
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
				"Fly",
				"Hyper-Beam",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Role-Play",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Extrasensory",
				"Block",
				"Bulk-Up",
				"Mud-Shot",
				"Calm-Mind",
				"Gravity",
				"Hammer-Arm",
				"U-Turn",
				"Payback",
				"Fling",
				"Punishment",
				"Rock-Polish",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Landorus-Incarnate PokemonInstance Class
	#region Landorus-Incarnate
	public class LandorusIncarnateInstance : PokemonInstance
	{
		#region Landorus-Incarnate Constructors
		/// <summary>
		/// Landorus-Incarnate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LandorusIncarnateInstance(string nickname, int level)
		: base(
				645,
				SpeciesLandorusIncarnate.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Landorus-Incarnate Builder only waiting for a Level
		/// </summary>
		public LandorusIncarnateInstance(int level)
		: base(
				645,
				SpeciesLandorusIncarnate.Instance, // PokemonInstance Species
				"Landorus-Incarnate", level,
				Ground.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Landorus-Incarnate Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public LandorusIncarnate() : base(
			645,
			SpeciesLandorusIncarnate.Instance, // PokemonInstance Species
			Ground.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}