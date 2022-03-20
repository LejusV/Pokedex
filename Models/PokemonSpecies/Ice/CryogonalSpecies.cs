using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cryogonal Species to store common natural stats of all Cryogonals
	#region CryogonalSpecies
	public class CryogonalSpecies : PokemonSpecies
	{
#nullable enable
		private static CryogonalSpecies? _instance = null;
#nullable restore
        public static CryogonalSpecies Instance => _instance ?? (_instance = new CryogonalSpecies());

		#region CryogonalSpecies Constructor
		public CryogonalSpecies() : base(
			615,
			"Cryogonal",
			Ice.Instance,
			1.1,
			148.0,
			new PokemonStats(
				80, // HPs
				50, 50, // Attack & Defense
				95, 135, // Spacial Attack & Defense
				105 // Speed
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
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Sharpen",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Sheer-Cold",
				"Iron-Defense",
				"Water-Pulse",
				"Poison-Jab",
				"Night-Slash",
				"Ice-Shard",
				"Flash-Cannon",
				"Round",
				"Acrobatics",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}