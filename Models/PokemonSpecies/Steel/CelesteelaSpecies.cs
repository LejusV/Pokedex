using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Celesteela Species to store common natural stats of all Celesteelas
	#region CelesteelaSpecies
	public class CelesteelaSpecies : PokemonSpecies
	{
#nullable enable
		private static CelesteelaSpecies? _instance = null;
#nullable restore
        public static CelesteelaSpecies Instance => _instance ?? (_instance = new CelesteelaSpecies());

		#region CelesteelaSpecies Constructor
		public CelesteelaSpecies() : base(
			797,
			"Celesteela",
			Steel.Instance, Flying.Instance,
			9.2,
			999.9,
			new PokemonStats(
				97, // HPs
				101, 103, // Attack & Defense
				107, 101, // Spacial Attack & Defense
				61 // Speed
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
				"Fly",
				"Tackle",
				"Double-Edge",
				"Flamethrower",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Harden",
				"Fire-Blast",
				"Skull-Bash",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Facade",
				"Ingrain",
				"Metal-Sound",
				"Iron-Defense",
				"Gyro-Ball",
				"Seed-Bomb",
				"Air-Slash",
				"Energy-Ball",
				"Giga-Impact",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Grass-Knot",
				"Wide-Guard",
				"Autotomize",
				"Smack-Down",
				"Heavy-Slam",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Bulldoze",
				"Confide",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}