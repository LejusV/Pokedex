using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Toxapex Species to store common natural stats of all Toxapexs
	#region SpeciesToxapex
	public class SpeciesToxapex : PokemonSpecies
	{
#nullable enable
		private static SpeciesToxapex? _instance = null;
#nullable restore
        public static SpeciesToxapex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesToxapex();
                }
                return _instance;
            }
        }

		#region SpeciesToxapex Constructor
		public SpeciesToxapex() : base(
			"Toxapex",
			0.7,
			14.5,
			50, // HPs
			63, 152, // Attack & Defense
			53, 142, // Special Attack & Defense
			35		
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
				"Poison-Sting",
				"Pin-Missile",
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Peck",
				"Toxic",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Spike-Cannon",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Hail",
				"Facade",
				"Payback",
				"Toxic-Spikes",
				"Poison-Jab",
				"Wide-Guard",
				"Venoshock",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Baneful-Bunker",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Toxapex PokemonInstance Class
	#region Toxapex
	public class ToxapexInstance : PokemonInstance
	{
		#region Toxapex Constructors
		/// <summary>
		/// Toxapex Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ToxapexInstance(string nickname, int level)
		: base(
				748,
				SpeciesToxapex.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxapex Builder only waiting for a Level
		/// </summary>
		public ToxapexInstance(int level)
		: base(
				748,
				SpeciesToxapex.Instance, // PokemonInstance Species
				"Toxapex", level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxapex Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Toxapex() : base(
			748,
			SpeciesToxapex.Instance, // PokemonInstance Species
			Poison.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}