using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sandile Species to store common natural stats of all Sandiles
	#region SpeciesSandile
	public class SpeciesSandile : PokemonSpecies
	{
#nullable enable
		private static SpeciesSandile? _instance = null;
#nullable restore
        public static SpeciesSandile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSandile();
                }
                return _instance;
            }
        }

		#region SpeciesSandile Constructor
		public SpeciesSandile() : base(
			551,
			"Sandile",
			0.7,
			15.2,
			50, // HPs
			72, 35, // Attack & Defense
			35, 35, // Special Attack & Defense
			65		
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
				"Cut",
				"Sand-Attack",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Counter",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Double-Team",
				"Focus-Energy",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Beat-Up",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Payback",
				"Assurance",
				"Embargo",
				"Me-First",
				"Dark-Pulse",
				"Aqua-Tail",
				"Earth-Power",
				"Thunder-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Snarl",
				"Confide",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion

	//Sandile PokemonInstance Class
	#region Sandile
	public class SandileInstance : PokemonInstance
	{
		#region Sandile Constructors
		/// <summary>
		/// Sandile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SandileInstance(string nickname, int level)
		: base(
				SpeciesSandile.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandile Builder only waiting for a Level
		/// </summary>
		public SandileInstance(int level)
		: base(
				SpeciesSandile.Instance, // PokemonInstance Species
				"Sandile", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SandileInstance() : base(
			SpeciesSandile.Instance, // PokemonInstance Species
			Ground.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}