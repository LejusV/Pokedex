using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Zygarde Species to store common natural stats of all Zygardes
	#region ZygardeSpecies
	public class ZygardeSpecies : PokemonSpecies
	{
#nullable enable
		private static ZygardeSpecies? _instance = null;
#nullable restore
        public static ZygardeSpecies Instance => _instance ?? (_instance = new ZygardeSpecies());

		#region ZygardeSpecies Constructor
		public ZygardeSpecies() : base(
			718,
			"Zygarde",
			Dragon.Instance, Ground.Instance,
			5.0,
			305.0,
			new PokemonStats(
				108, // HPs
				100, 121, // Attack & Defense
				81, 95, // Spacial Attack & Defense
				95 // Speed
			)			
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
}