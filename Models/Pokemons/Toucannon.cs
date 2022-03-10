using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Toucannon Species to store common natural stats of all Toucannons
	#region SpeciesToucannon
	public class SpeciesToucannon : PokemonSpecies
	{
#nullable enable
		private static SpeciesToucannon? _instance = null;
#nullable restore
        public static SpeciesToucannon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesToucannon();
                }
                return _instance;
            }
        }

		#region SpeciesToucannon Constructor
		public SpeciesToucannon() : base(
			"Toucannon",
			1.1,
			26.0,
			80, // HPs
			120, 75, // Attack & Defense
			75, 75, // Special Attack & Defense
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
				"Swords-Dance",
				"Fly",
				"Fury-Attack",
				"Growl",
				"Supersonic",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Brick-Break",
				"Feather-Dance",
				"Hyper-Voice",
				"Overheat",
				"Bullet-Seed",
				"Aerial-Ace",
				"Rock-Blast",
				"Roost",
				"Pluck",
				"U-Turn",
				"Flash-Cannon",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide",
				"Beak-Blast"
			};
		}
		#endregion
	}
	#endregion

	//Toucannon PokemonInstance Class
	#region Toucannon
	public class ToucannonInstance : PokemonInstance
	{
		#region Toucannon Constructors
		/// <summary>
		/// Toucannon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ToucannonInstance(string nickname, int level)
		: base(
				733,
				SpeciesToucannon.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toucannon Builder only waiting for a Level
		/// </summary>
		public ToucannonInstance(int level)
		: base(
				733,
				SpeciesToucannon.Instance, // PokemonInstance Species
				"Toucannon", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toucannon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Toucannon() : base(
			733,
			SpeciesToucannon.Instance, // PokemonInstance Species
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}