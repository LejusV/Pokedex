using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Araquanid Species to store common natural stats of all Araquanids
	#region SpeciesAraquanid
	public class SpeciesAraquanid : PokemonSpecies
	{
#nullable enable
		private static SpeciesAraquanid? _instance = null;
#nullable restore
        public static SpeciesAraquanid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAraquanid();
                }
                return _instance;
            }
        }

		#region SpeciesAraquanid Constructor
		public SpeciesAraquanid() : base(
			752,
			"Araquanid",
			1.8,
			82.0,
			68, // HPs
			70, 92, // Attack & Defense
			50, 132, // Special Attack & Defense
			42		
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
				"Bite",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Waterfall",
				"Leech-Life",
				"Bubble",
				"Rest",
				"Substitute",
				"Spider-Web",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Mirror-Coat",
				"Facade",
				"Aqua-Ring",
				"Poison-Jab",
				"X-Scissor",
				"Bug-Bite",
				"Wide-Guard",
				"Soak",
				"Entrainment",
				"Round",
				"Scald",
				"Frost-Breath",
				"Confide",
				"Infestation",
				"Lunge",
				"Liquidation"
			};
		}
		#endregion
	}
	#endregion

	//Araquanid PokemonInstance Class
	#region Araquanid
	public class AraquanidInstance : PokemonInstance
	{
		#region Araquanid Constructors
		/// <summary>
		/// Araquanid Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AraquanidInstance(string nickname, int level)
		: base(
				SpeciesAraquanid.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Araquanid Builder only waiting for a Level
		/// </summary>
		public AraquanidInstance(int level)
		: base(
				SpeciesAraquanid.Instance, // PokemonInstance Species
				"Araquanid", level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Araquanid Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AraquanidInstance() : base(
			SpeciesAraquanid.Instance, // PokemonInstance Species
			Water.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}