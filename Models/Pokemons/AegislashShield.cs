using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aegislash-Shield Specie to store common natural stats of every {'abilities': ['stance-change'], 'base_experience': 234, 'height': 17, 'id': 681, 'moves': ['swords-dance', 'cut', 'hyper-beam', 'toxic', 'double-team', 'reflect', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'spite', 'protect', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'aerial-ace', 'iron-defense', 'block', 'shock-wave', 'gyro-ball', 'power-trick', 'magnet-rise', 'night-slash', 'giga-impact', 'shadow-claw', 'shadow-sneak', 'flash-cannon', 'iron-head', 'head-smash', 'autotomize', 'after-you', 'round', 'retaliate', 'sacred-sword', 'kings-shield', 'confide', 'brutal-swing'], 'name': 'aegislash-shield', 'stats': {'hp': 60, 'attack': 50, 'defense': 140, 'special-attack': 50, 'special-defense': 140, 'speed': 60}, 'types': ['steel', 'ghost'], 'weight': 530, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ギルガルド', 'ko': '킬가르도', 'zh-Hant': '堅盾劍怪', 'fr': 'Exagide', 'de': 'Durengard', 'es': 'Aegislash', 'it': 'Aegislash', 'en': 'Aegislash', 'ja': 'ギルガルド', 'zh-Hans': '坚盾剑怪'}, 'genera': {'ja-Hrkt': 'おうけんポケモン', 'ko': '왕검포켓몬', 'zh-Hant': '王劍寶可夢', 'fr': 'Pokémon Noble Lame', 'de': 'Königsklinge', 'es': 'Pokémon Espada Real', 'it': 'Pokémon Spadareale', 'en': 'Royal Sword Pokémon', 'ja': 'おうけんポケモン', 'zh-Hans': '王剑宝可梦'}}
	public class SpecieAegislashShield : PokemonSpecie
	{
#nullable enable
		private static SpecieAegislashShield? _instance = null;
#nullable restore
        public static SpecieAegislashShield Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAegislashShield();
                }
                return _instance;
            }
        }

		public SpecieAegislashShield() : base(
			"Aegislash-Shield",
			60, // HPs
			50, 140, // Attack & Defense
			50, 140, // Special Attack & Defense
			60			
		) {}
	}


	//Aegislash-Shield Pokemon Class
	public class AegislashShield : Pokemon
	{

		public AegislashShield(string nickname, int level) : base(
			681,
			SpecieAegislashShield.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Ghost.Instance			
		) {}

		public AegislashShield() : base(
			681,
			SpecieAegislashShield.Instance, // Pokemon Specie
			Steel.Instance, Ghost.Instance			
		) {}
	}
}