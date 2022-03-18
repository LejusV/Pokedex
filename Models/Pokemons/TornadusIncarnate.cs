using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tornadus-Incarnate Species to store common natural stats of all Tornadus-Incarnates
	#region SpeciesTornadus-Incarnate
	public class SpeciesTornadusIncarnate : PokemonSpecies
	{
#nullable enable
		private static SpeciesTornadusIncarnate? _instance = null;
#nullable restore
        public static SpeciesTornadusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTornadusIncarnate();
                }
                return _instance;
            }
        }

		#region SpeciesTornadus-Incarnate Constructor
		public SpeciesTornadusIncarnate() : base(
			641,
			"Tornadus-Incarnate",
			1.5,
			63.0,
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
				"Gust",
				"Fly",
				"Thrash",
				"Bite",
				"Hyper-Beam",
				"Strength",
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
				"Icy-Wind",
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
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Role-Play",
				"Superpower",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Secret-Power",
				"Astonish",
				"Air-Cutter",
				"Extrasensory",
				"Aerial-Ace",
				"Bulk-Up",
				"Hammer-Arm",
				"Tailwind",
				"U-Turn",
				"Payback",
				"Embargo",
				"Fling",
				"Dark-Pulse",
				"Air-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Grass-Knot",
				"Smack-Down",
				"Sludge-Wave",
				"Foul-Play",
				"Round",
				"Sky-Drop",
				"Incinerate",
				"Acrobatics",
				"Hurricane",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Tornadus-Incarnate PokemonInstance Class
	#region Tornadus-Incarnate
	public class TornadusIncarnateInstance : PokemonInstance
	{
		#region Tornadus-Incarnate Constructors
		/// <summary>
		/// Tornadus-Incarnate Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TornadusIncarnateInstance(string nickname, int level)
		: base(
				SpeciesTornadusIncarnate.Instance, // Pokemon Species
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tornadus-Incarnate Builder only waiting for a Level
		/// </summary>
		public TornadusIncarnateInstance(int level)
		: base(
				SpeciesTornadusIncarnate.Instance, // PokemonInstance Species
				"Tornadus-Incarnate", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tornadus-Incarnate Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TornadusIncarnateInstance() : base(
			SpeciesTornadusIncarnate.Instance, // PokemonInstance Species
			Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}