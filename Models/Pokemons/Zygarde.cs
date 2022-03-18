using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Zygarde Species to store common natural stats of all Zygardes
	#region SpeciesZygarde
	public class SpeciesZygarde : PokemonSpecies
	{
#nullable enable
		private static SpeciesZygarde? _instance = null;
#nullable restore
        public static SpeciesZygarde Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesZygarde();
                }
                return _instance;
            }
        }

		#region SpeciesZygarde Constructor
		public SpeciesZygarde() : base(
			718,
			"Zygarde",
			5.0,
			305.0,
			108, // HPs
			100, 121, // Attack & Defense
			81, 95, // Special Attack & Defense
			95		
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
				"Bind",
				"Bite",
				"Hyper-Beam",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Haze",
				"Glare",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Extreme-Speed",
				"Rock-Smash",
				"Facade",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Camouflage",
				"Hyper-Voice",
				"Block",
				"Dragon-Dance",
				"Shock-Wave",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Draco-Meteor",
				"Stone-Edge",
				"Grass-Knot",
				"Sludge-Wave",
				"Coil",
				"Round",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Lands-Wrath"
			};
		}
		#endregion
	}
	#endregion

	//Zygarde PokemonInstance Class
	#region Zygarde
	public class ZygardeInstance : PokemonInstance
	{
		#region Zygarde Constructors
		/// <summary>
		/// Zygarde Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ZygardeInstance(string nickname, int level)
		: base(
				SpeciesZygarde.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zygarde Builder only waiting for a Level
		/// </summary>
		public ZygardeInstance(int level)
		: base(
				SpeciesZygarde.Instance, // PokemonInstance Species
				"Zygarde", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zygarde Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ZygardeInstance() : base(
			SpeciesZygarde.Instance, // PokemonInstance Species
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}