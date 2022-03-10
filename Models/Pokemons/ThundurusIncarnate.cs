using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Thundurus-Incarnate Species to store common natural stats of all Thundurus-Incarnates
	#region SpeciesThundurus-Incarnate
	public class SpeciesThundurusIncarnate : PokemonSpecies
	{
#nullable enable
		private static SpeciesThundurusIncarnate? _instance = null;
#nullable restore
        public static SpeciesThundurusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesThundurusIncarnate();
                }
                return _instance;
            }
        }

		#region SpeciesThundurus-Incarnate Constructor
		public SpeciesThundurusIncarnate() : base(
			"Thundurus-Incarnate",
			1.5,
			61.0,
			79, // HPs
			115, 70, // Attack & Defense
			125, 80, // Special Attack & Defense
			111		
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
				"Thunder-Punch",
				"Fly",
				"Thrash",
				"Bite",
				"Hyper-Beam",
				"Strength",
				"Thunder-Shock",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Agility",
				"Double-Team",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Rock-Smash",
				"Uproar",
				"Torment",
				"Facade",
				"Charge",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Astonish",
				"Bulk-Up",
				"Shock-Wave",
				"Hammer-Arm",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Heal-Block",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Flash-Cannon",
				"Discharge",
				"Grass-Knot",
				"Charge-Beam",
				"Smack-Down",
				"Sludge-Wave",
				"Foul-Play",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Volt-Switch",
				"Electroweb",
				"Wild-Charge",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Thundurus-Incarnate PokemonInstance Class
	#region Thundurus-Incarnate
	public class ThundurusIncarnateInstance : PokemonInstance
	{
		#region Thundurus-Incarnate Constructors
		/// <summary>
		/// Thundurus-Incarnate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ThundurusIncarnateInstance(string nickname, int level)
		: base(
				642,
				SpeciesThundurusIncarnate.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thundurus-Incarnate Builder only waiting for a Level
		/// </summary>
		public ThundurusIncarnateInstance(int level)
		: base(
				642,
				SpeciesThundurusIncarnate.Instance, // PokemonInstance Species
				"Thundurus-Incarnate", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thundurus-Incarnate Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ThundurusIncarnate() : base(
			642,
			SpeciesThundurusIncarnate.Instance, // PokemonInstance Species
			Electric.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}