using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Tyrogue Species to store common natural stats of all Tyrogues
	#region SpeciesTyrogue
	public class SpeciesTyrogue : PokemonSpecies
	{
#nullable enable
		private static SpeciesTyrogue? _instance = null;
#nullable restore
        public static SpeciesTyrogue Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTyrogue();
                }
                return _instance;
            }
        }

		#region SpeciesTyrogue Constructor
		public SpeciesTyrogue() : base(
			236,
			"Tyrogue",
			0.7,
			21.0,
			35, // HPs
			35, 35, // Attack & Defense
			35, 35, // Special Attack & Defense
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
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Swift",
				"High-Jump-Kick",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Mind-Reader",
				"Snore",
				"Curse",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Rock-Smash",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Secret-Power",
				"Bulk-Up",
				"Covet",
				"Natural-Gift",
				"Feint",
				"Vacuum-Wave",
				"Bullet-Punch",
				"Captivate",
				"Low-Sweep",
				"Round",
				"Ally-Switch",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Tyrogue PokemonInstance Class
	#region Tyrogue
	public class TyrogueInstance : PokemonInstance
	{
		#region Tyrogue Constructors
		/// <summary>
		/// Tyrogue Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TyrogueInstance(string nickname, int level)
		: base(
				SpeciesTyrogue.Instance, // Pokemon Species
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrogue Builder only waiting for a Level
		/// </summary>
		public TyrogueInstance(int level)
		: base(
				SpeciesTyrogue.Instance, // PokemonInstance Species
				"Tyrogue", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrogue Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TyrogueInstance() : base(
			SpeciesTyrogue.Instance, // PokemonInstance Species
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}