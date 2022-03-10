using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Honedge Species to store common natural stats of all Honedges
	#region SpeciesHonedge
	public class SpeciesHonedge : PokemonSpecies
	{
#nullable enable
		private static SpeciesHonedge? _instance = null;
#nullable restore
        public static SpeciesHonedge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesHonedge();
                }
                return _instance;
            }
        }

		#region SpeciesHonedge Constructor
		public SpeciesHonedge() : base(
			"Honedge",
			0.8,
			2.0,
			45, // HPs
			80, 100, // Attack & Defense
			35, 37, // Special Attack & Defense
			28		
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
				"Cut",
				"Tackle",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Destiny-Bond",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Shock-Wave",
				"Gyro-Ball",
				"Power-Trick",
				"Magnet-Rise",
				"Night-Slash",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Flash-Cannon",
				"Iron-Head",
				"Wide-Guard",
				"Autotomize",
				"After-You",
				"Retaliate",
				"Sacred-Sword",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Honedge PokemonInstance Class
	#region Honedge
	public class HonedgeInstance : PokemonInstance
	{
		#region Honedge Constructors
		/// <summary>
		/// Honedge Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HonedgeInstance(string nickname, int level)
		: base(
				679,
				SpeciesHonedge.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honedge Builder only waiting for a Level
		/// </summary>
		public HonedgeInstance(int level)
		: base(
				679,
				SpeciesHonedge.Instance, // PokemonInstance Species
				"Honedge", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honedge Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Honedge() : base(
			679,
			SpeciesHonedge.Instance, // PokemonInstance Species
			Steel.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}