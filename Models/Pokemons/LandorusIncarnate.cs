using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Landorus-Incarnate Specie to store common natural stats of every {'abilities': ['sand-force', 'sheer-force'], 'base_experience': 270, 'height': 15, 'id': 645, 'moves': ['swords-dance', 'fly', 'hyper-beam', 'strength', 'rock-throw', 'earthquake', 'fissure', 'dig', 'toxic', 'psychic', 'double-team', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sludge-bomb', 'outrage', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rock-smash', 'facade', 'role-play', 'superpower', 'brick-break', 'knock-off', 'imprison', 'secret-power', 'rock-tomb', 'extrasensory', 'block', 'bulk-up', 'mud-shot', 'calm-mind', 'gravity', 'hammer-arm', 'u-turn', 'payback', 'fling', 'punishment', 'rock-polish', 'focus-blast', 'earth-power', 'giga-impact', 'stone-edge', 'stealth-rock', 'grass-knot', 'smack-down', 'sludge-wave', 'round', 'bulldoze', 'confide', 'brutal-swing'], 'name': 'landorus-incarnate', 'stats': {'hp': 89, 'attack': 125, 'defense': 90, 'special-attack': 115, 'special-defense': 80, 'speed': 101}, 'types': ['ground', 'flying'], 'weight': 680, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 0, 'capture_rate': 3, 'color': 'brown', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ランドロス', 'ko': '랜드로스', 'zh-Hant': '土地雲', 'fr': 'Démétéros', 'de': 'Demeteros', 'es': 'Landorus', 'it': 'Landorus', 'en': 'Landorus', 'ja': 'ランドロス', 'zh-Hans': '土地云'}, 'genera': {'ja-Hrkt': 'ほうじょうポケモン', 'ko': '풍요포켓몬', 'zh-Hant': '豐饒寶可夢', 'fr': 'Pokémon Fertilité', 'de': 'Reichtum', 'es': 'Pokémon Fertilidad', 'it': 'Pokémon Fertilità', 'en': 'Abundance Pokémon', 'ja': 'ほうじょうポケモン', 'zh-Hans': '丰饶宝可梦'}}
	public class SpecieLandorusIncarnate : PokemonSpecie
	{
#nullable enable
		private static SpecieLandorusIncarnate? _instance = null;
#nullable restore
        public static SpecieLandorusIncarnate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLandorusIncarnate();
                }
                return _instance;
            }
        }

		public SpecieLandorusIncarnate() : base(
			"Landorus-Incarnate",
			89, // HPs
			125, 90, // Attack & Defense
			115, 80, // Special Attack & Defense
			101			
		) {}
	}


	//Landorus-Incarnate Pokemon Class
	public class LandorusIncarnate : Pokemon
	{

		public LandorusIncarnate(string nickname, int level) : base(
			645,
			SpecieLandorusIncarnate.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance, Flying.Instance			
		) {}

		public LandorusIncarnate() : base(
			645,
			SpecieLandorusIncarnate.Instance, // Pokemon Specie
			Ground.Instance, Flying.Instance			
		) {}
	}
}