using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rampardos Specie to store common natural stats of every {'abilities': ['mold-breaker', 'sheer-force'], 'base_experience': 173, 'height': 16, 'id': 409, 'moves': ['fire-punch', 'thunder-punch', 'swords-dance', 'cut', 'headbutt', 'take-down', 'leer', 'roar', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder', 'earthquake', 'dig', 'toxic', 'screech', 'double-team', 'focus-energy', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'outrage', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'focus-punch', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'shock-wave', 'natural-gift', 'payback', 'assurance', 'fling', 'rock-polish', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'head-smash', 'smack-down', 'round', 'chip-away', 'incinerate', 'bulldoze', 'dragon-tail', 'confide', 'power-up-punch'], 'name': 'rampardos', 'stats': {'hp': 97, 'attack': 165, 'defense': 60, 'special-attack': 65, 'special-defense': 50, 'speed': 58}, 'types': ['rock'], 'weight': 1025, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'ラムパルド', 'roomaji': 'Rampard', 'ko': '램펄드', 'zh-Hant': '戰槌龍', 'fr': 'Charkos', 'de': 'Rameidon', 'es': 'Rampardos', 'it': 'Rampardos', 'en': 'Rampardos', 'ja': 'ラムパルド', 'zh-Hans': '战槌龙'}, 'genera': {'ja-Hrkt': 'ずつきポケモン', 'ko': '박치기포켓몬', 'zh-Hant': '頭錘寶可夢', 'fr': 'Pokémon Coud’Boule', 'de': 'Kopfstoß', 'es': 'Pokémon Cabezazo', 'it': 'Pokémon Cranioso', 'en': 'Head Butt Pokémon', 'ja': 'ずつきポケモン', 'zh-Hans': '头锤宝可梦'}}
	public class SpecieRampardos : PokemonSpecie
	{
#nullable enable
		private static SpecieRampardos? _instance = null;
#nullable restore
        public static SpecieRampardos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRampardos();
                }
                return _instance;
            }
        }

		public SpecieRampardos() : base(
			"Rampardos",
			97, // HPs
			165, 60, // Attack & Defense
			65, 50, // Special Attack & Defense
			58			
		) {}
	}


	//Rampardos Pokemon Class
	public class Rampardos : Pokemon
	{

		public Rampardos(string nickname, int level) : base(
			409,
			SpecieRampardos.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance			
		) {}

		public Rampardos() : base(
			409,
			SpecieRampardos.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}